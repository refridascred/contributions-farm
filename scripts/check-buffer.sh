#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open; do
    log "checking ${item}"
done

BUFFER_LIMIT=24
log "limit is ${BUFFER_LIMIT}"
