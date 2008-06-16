#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=225
log "limit is ${BUFFER_LIMIT}"

for item in stable blue green; do
    log "checking ${item}"
done
