#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable cached; do
    log "checking ${item}"
done

RECORD_LIMIT=228
log "limit is ${RECORD_LIMIT}"
