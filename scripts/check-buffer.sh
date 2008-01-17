#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=27
log "limit is ${BUFFER_LIMIT}"

for item in strict open; do
    log "checking ${item}"
done
