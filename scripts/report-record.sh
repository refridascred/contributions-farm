#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=395
log "limit is ${RECORD_LIMIT}"
