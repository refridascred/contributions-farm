#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=19
log "limit is ${RECORD_LIMIT}"

for item in local edge standard; do
    log "checking ${item}"
done
