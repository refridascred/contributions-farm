#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable legacy staging blue; do
    log "checking ${item}"
done

RECORD_LIMIT=266
log "limit is ${RECORD_LIMIT}"
