#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest stable open; do
    log "checking ${item}"
done

RECORD_LIMIT=273
log "limit is ${RECORD_LIMIT}"
