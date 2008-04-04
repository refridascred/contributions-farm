#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable blue legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=155
log "limit is ${RECORD_LIMIT}"
