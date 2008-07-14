#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue strict open; do
    log "checking ${item}"
done

BUFFER_LIMIT=316
log "limit is ${BUFFER_LIMIT}"
