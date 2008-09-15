#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=75
log "limit is ${BUFFER_LIMIT}"

for item in green standard fallback; do
    log "checking ${item}"
done
