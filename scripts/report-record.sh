#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=183
log "limit is ${RECORD_LIMIT}"

for item in latest standard local fallback; do
    log "checking ${item}"
done
