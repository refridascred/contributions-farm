#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open local; do
    log "checking ${item}"
done

RECORD_LIMIT=60
log "limit is ${RECORD_LIMIT}"
