#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=472
log "limit is ${BUFFER_LIMIT}"
