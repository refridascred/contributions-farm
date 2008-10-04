#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=490
log "limit is ${BUFFER_LIMIT}"
