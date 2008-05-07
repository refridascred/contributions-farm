#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable local open; do
    log "checking ${item}"
done

RECORD_LIMIT=95
log "limit is ${RECORD_LIMIT}"
