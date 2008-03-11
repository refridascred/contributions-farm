#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green strict stable staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=169
log "limit is ${BUFFER_LIMIT}"
