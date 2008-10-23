#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=5
log "limit is ${BUFFER_LIMIT}"
