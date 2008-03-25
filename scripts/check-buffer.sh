#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached latest fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=266
log "limit is ${BUFFER_LIMIT}"
