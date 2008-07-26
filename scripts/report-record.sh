#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=462
log "limit is ${RECORD_LIMIT}"

for item in latest stable green; do
    log "checking ${item}"
done
