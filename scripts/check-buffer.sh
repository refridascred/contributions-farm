#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=118
log "limit is ${BUFFER_LIMIT}"
