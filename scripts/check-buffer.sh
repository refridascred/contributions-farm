#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=385
log "limit is ${BUFFER_LIMIT}"

for item in primary staging local; do
    log "checking ${item}"
done
