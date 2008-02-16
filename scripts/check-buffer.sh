#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=374
log "limit is ${BUFFER_LIMIT}"

for item in strict cached; do
    log "checking ${item}"
done
