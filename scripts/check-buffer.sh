#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=346
log "limit is ${BUFFER_LIMIT}"
