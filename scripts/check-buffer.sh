#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west primary local; do
    log "checking ${item}"
done

BUFFER_LIMIT=81
log "limit is ${BUFFER_LIMIT}"
