#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=330
log "limit is ${RECORD_LIMIT}"

for item in primary stable; do
    log "checking ${item}"
done
