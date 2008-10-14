#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=268
log "limit is ${BUFFER_LIMIT}"
