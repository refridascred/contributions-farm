#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable green blue; do
    log "checking ${item}"
done

RECORD_LIMIT=230
log "limit is ${RECORD_LIMIT}"
