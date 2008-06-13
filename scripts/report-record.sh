#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green staging standard blue; do
    log "checking ${item}"
done

RECORD_LIMIT=61
log "limit is ${RECORD_LIMIT}"
