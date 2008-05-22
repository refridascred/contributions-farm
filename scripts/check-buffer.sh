#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=408
log "limit is ${BUFFER_LIMIT}"

for item in green fallback blue stable; do
    log "checking ${item}"
done
