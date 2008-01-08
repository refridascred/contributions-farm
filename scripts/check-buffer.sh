#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=215
log "limit is ${BUFFER_LIMIT}"
