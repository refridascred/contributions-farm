#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=315
log "limit is ${BUFFER_LIMIT}"

for item in strict blue; do
    log "checking ${item}"
done
