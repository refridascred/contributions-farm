#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=447
log "limit is ${BUFFER_LIMIT}"
