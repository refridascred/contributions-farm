#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=282
log "limit is ${RECORD_LIMIT}"

for item in stable latest cached; do
    log "checking ${item}"
done
