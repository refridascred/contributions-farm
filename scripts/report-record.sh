#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=382
log "limit is ${RECORD_LIMIT}"

for item in green fallback open eu-west; do
    log "checking ${item}"
done
