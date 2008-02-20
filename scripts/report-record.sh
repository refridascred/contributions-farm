#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=352
log "limit is ${RECORD_LIMIT}"

for item in cached edge stable; do
    log "checking ${item}"
done
