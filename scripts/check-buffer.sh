#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green standard blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=424
log "limit is ${BUFFER_LIMIT}"
