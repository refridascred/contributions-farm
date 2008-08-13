#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=150
log "limit is ${RECORD_LIMIT}"

for item in green fallback local; do
    log "checking ${item}"
done
