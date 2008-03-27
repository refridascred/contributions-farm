#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable latest; do
    log "checking ${item}"
done

RECORD_LIMIT=442
log "limit is ${RECORD_LIMIT}"
