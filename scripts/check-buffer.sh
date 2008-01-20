#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached standard eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=465
log "limit is ${BUFFER_LIMIT}"
