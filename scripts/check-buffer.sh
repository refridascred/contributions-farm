#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=272
log "limit is ${BUFFER_LIMIT}"

for item in cached fallback strict; do
    log "checking ${item}"
done
