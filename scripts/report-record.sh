#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open; do
    log "checking ${item}"
done

RECORD_LIMIT=149
log "limit is ${RECORD_LIMIT}"
