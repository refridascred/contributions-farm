#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=387
log "limit is ${BUFFER_LIMIT}"

for item in strict eu-west edge; do
    log "checking ${item}"
done
