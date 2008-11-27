#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=106
log "limit is ${BUFFER_LIMIT}"

for item in primary fallback cached eu-west; do
    log "checking ${item}"
done
