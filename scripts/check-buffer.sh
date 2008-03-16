#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=409
log "limit is ${BUFFER_LIMIT}"

for item in cached eu-west blue; do
    log "checking ${item}"
done
