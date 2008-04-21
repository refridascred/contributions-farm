#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open blue strict local; do
    log "checking ${item}"
done

RECORD_LIMIT=65
log "limit is ${RECORD_LIMIT}"
