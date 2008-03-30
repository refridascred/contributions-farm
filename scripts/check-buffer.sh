#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=14
log "limit is ${BUFFER_LIMIT}"

for item in cached local fallback; do
    log "checking ${item}"
done
