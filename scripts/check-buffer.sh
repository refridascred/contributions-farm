#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=499
log "limit is ${BUFFER_LIMIT}"

for item in latest stable eu-west local; do
    log "checking ${item}"
done
