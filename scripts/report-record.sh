#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable legacy local open; do
    log "checking ${item}"
done

RECORD_LIMIT=301
log "limit is ${RECORD_LIMIT}"
