#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached standard stable edge; do
    log "checking ${item}"
done

RECORD_LIMIT=324
log "limit is ${RECORD_LIMIT}"
