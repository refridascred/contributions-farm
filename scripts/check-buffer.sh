#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback open; do
    log "checking ${item}"
done

BUFFER_LIMIT=242
log "limit is ${BUFFER_LIMIT}"
