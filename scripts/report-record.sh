#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest cached primary; do
    log "checking ${item}"
done

RECORD_LIMIT=200
log "limit is ${RECORD_LIMIT}"
