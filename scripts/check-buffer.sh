#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=453
log "limit is ${BUFFER_LIMIT}"

for item in legacy strict staging blue; do
    log "checking ${item}"
done
