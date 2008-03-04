#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest edge staging cached; do
    log "checking ${item}"
done

RECORD_LIMIT=242
log "limit is ${RECORD_LIMIT}"
