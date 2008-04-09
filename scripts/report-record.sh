#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy standard primary open; do
    log "checking ${item}"
done

RECORD_LIMIT=293
log "limit is ${RECORD_LIMIT}"
