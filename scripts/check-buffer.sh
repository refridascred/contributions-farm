#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green eu-west staging cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=406
log "limit is ${BUFFER_LIMIT}"
