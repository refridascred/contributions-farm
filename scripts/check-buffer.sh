#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary open local; do
    log "checking ${item}"
done

BUFFER_LIMIT=359
log "limit is ${BUFFER_LIMIT}"
