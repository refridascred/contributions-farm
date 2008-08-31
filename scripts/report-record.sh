#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=67
log "limit is ${RECORD_LIMIT}"
