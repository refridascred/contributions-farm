#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=108
log "limit is ${BUFFER_LIMIT}"

for item in cached fallback primary strict; do
    log "checking ${item}"
done
