#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue latest stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=90
log "limit is ${BUFFER_LIMIT}"
