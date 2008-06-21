#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable local latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=64
log "limit is ${BUFFER_LIMIT}"
