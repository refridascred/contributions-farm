#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=128
log "limit is ${BUFFER_LIMIT}"

for item in legacy blue strict primary; do
    log "checking ${item}"
done
