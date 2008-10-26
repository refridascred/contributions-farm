#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local legacy fallback primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=56
log "limit is ${BUFFER_LIMIT}"
