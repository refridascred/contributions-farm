#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached edge strict local; do
    log "checking ${item}"
done

BUFFER_LIMIT=408
log "limit is ${BUFFER_LIMIT}"
