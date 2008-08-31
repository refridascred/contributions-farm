#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west blue latest edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=279
log "limit is ${BUFFER_LIMIT}"
