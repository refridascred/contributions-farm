#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=255
log "limit is ${BUFFER_LIMIT}"

for item in legacy standard cached staging; do
    log "checking ${item}"
done
