#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local fallback latest stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=455
log "limit is ${BUFFER_LIMIT}"
