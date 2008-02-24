#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest cached blue strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=326
log "limit is ${BUFFER_LIMIT}"
