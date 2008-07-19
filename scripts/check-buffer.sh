#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=232
log "limit is ${BUFFER_LIMIT}"

for item in stable strict local; do
    log "checking ${item}"
done
