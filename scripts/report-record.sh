#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local fallback edge blue; do
    log "checking ${item}"
done

RECORD_LIMIT=446
log "limit is ${RECORD_LIMIT}"
