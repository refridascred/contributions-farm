#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached stable fallback open; do
    log "checking ${item}"
done

RECORD_LIMIT=497
log "limit is ${RECORD_LIMIT}"
