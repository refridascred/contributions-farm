#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west blue strict; do
    log "checking ${item}"
done

RECORD_LIMIT=359
log "limit is ${RECORD_LIMIT}"
