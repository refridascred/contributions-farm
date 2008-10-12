#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest cached legacy open; do
    log "checking ${item}"
done

BUFFER_LIMIT=290
log "limit is ${BUFFER_LIMIT}"
