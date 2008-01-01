#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open blue latest legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=331
log "limit is ${BUFFER_LIMIT}"
