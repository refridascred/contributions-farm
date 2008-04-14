#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable blue fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=114
log "limit is ${BUFFER_LIMIT}"
