#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest local; do
    log "checking ${item}"
done

BUFFER_LIMIT=439
log "limit is ${BUFFER_LIMIT}"
