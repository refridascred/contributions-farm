#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=367
log "limit is ${BUFFER_LIMIT}"
