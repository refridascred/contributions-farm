#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=436
log "limit is ${BUFFER_LIMIT}"

for item in local green; do
    log "checking ${item}"
done
