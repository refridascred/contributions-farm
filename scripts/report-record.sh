#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback edge legacy staging; do
    log "checking ${item}"
done

RECORD_LIMIT=297
log "limit is ${RECORD_LIMIT}"
