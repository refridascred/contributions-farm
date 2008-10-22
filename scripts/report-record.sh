#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy staging strict blue; do
    log "checking ${item}"
done

RECORD_LIMIT=237
log "limit is ${RECORD_LIMIT}"
