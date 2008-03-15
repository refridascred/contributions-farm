#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=38
log "limit is ${RECORD_LIMIT}"

for item in open standard; do
    log "checking ${item}"
done
