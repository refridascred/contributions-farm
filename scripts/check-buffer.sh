#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary legacy staging blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=188
log "limit is ${BUFFER_LIMIT}"
