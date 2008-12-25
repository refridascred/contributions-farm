#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=160
log "limit is ${BUFFER_LIMIT}"
