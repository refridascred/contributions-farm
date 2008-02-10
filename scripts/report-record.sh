#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached fallback eu-west strict; do
    log "checking ${item}"
done

RECORD_LIMIT=409
log "limit is ${RECORD_LIMIT}"
