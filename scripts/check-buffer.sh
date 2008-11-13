#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=263
log "limit is ${BUFFER_LIMIT}"

for item in stable open; do
    log "checking ${item}"
done
