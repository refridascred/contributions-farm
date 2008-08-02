#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=440
log "limit is ${BUFFER_LIMIT}"

for item in latest strict; do
    log "checking ${item}"
done
