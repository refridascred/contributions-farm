#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=282
log "limit is ${BUFFER_LIMIT}"

for item in blue legacy; do
    log "checking ${item}"
done
