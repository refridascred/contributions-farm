#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy blue; do
    log "checking ${item}"
done

RECORD_LIMIT=188
log "limit is ${RECORD_LIMIT}"
