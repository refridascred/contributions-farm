#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy standard cached fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=479
log "limit is ${BUFFER_LIMIT}"
