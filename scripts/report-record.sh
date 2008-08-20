#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=364
log "limit is ${RECORD_LIMIT}"

for item in cached fallback local blue; do
    log "checking ${item}"
done
