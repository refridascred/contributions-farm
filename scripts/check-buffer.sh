#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=254
log "limit is ${BUFFER_LIMIT}"

for item in standard stable; do
    log "checking ${item}"
done
