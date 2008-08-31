#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached primary open; do
    log "checking ${item}"
done

BUFFER_LIMIT=16
log "limit is ${BUFFER_LIMIT}"
