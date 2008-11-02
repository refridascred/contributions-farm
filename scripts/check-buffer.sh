#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green eu-west legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=181
log "limit is ${BUFFER_LIMIT}"
