#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open eu-west primary cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=84
log "limit is ${BUFFER_LIMIT}"
