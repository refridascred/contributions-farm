#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable primary fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=23
log "limit is ${BUFFER_LIMIT}"
