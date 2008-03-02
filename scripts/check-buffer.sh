#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict blue local; do
    log "checking ${item}"
done

BUFFER_LIMIT=132
log "limit is ${BUFFER_LIMIT}"
