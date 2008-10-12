#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict stable open; do
    log "checking ${item}"
done

RECORD_LIMIT=170
log "limit is ${RECORD_LIMIT}"
