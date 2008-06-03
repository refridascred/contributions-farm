#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local fallback standard primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=476
log "limit is ${BUFFER_LIMIT}"
