#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=117
log "limit is ${BUFFER_LIMIT}"

for item in fallback blue legacy stable; do
    log "checking ${item}"
done
