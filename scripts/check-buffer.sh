#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge standard cached fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=385
log "limit is ${BUFFER_LIMIT}"
