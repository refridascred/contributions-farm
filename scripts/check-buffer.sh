#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy primary local latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=236
log "limit is ${BUFFER_LIMIT}"
