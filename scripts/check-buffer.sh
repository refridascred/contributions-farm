#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=156
log "limit is ${BUFFER_LIMIT}"

for item in blue green fallback; do
    log "checking ${item}"
done
