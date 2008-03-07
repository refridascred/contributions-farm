#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local fallback strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=436
log "limit is ${BUFFER_LIMIT}"
