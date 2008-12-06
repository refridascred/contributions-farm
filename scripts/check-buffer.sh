#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local primary latest blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=72
log "limit is ${BUFFER_LIMIT}"
