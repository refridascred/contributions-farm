#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable standard primary edge; do
    log "checking ${item}"
done

RECORD_LIMIT=327
log "limit is ${RECORD_LIMIT}"
