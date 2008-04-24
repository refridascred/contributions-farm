#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=372
log "limit is ${BUFFER_LIMIT}"

for item in open local legacy blue; do
    log "checking ${item}"
done
