#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard latest blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=324
log "limit is ${BUFFER_LIMIT}"
