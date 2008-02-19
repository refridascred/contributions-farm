#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest staging primary open; do
    log "checking ${item}"
done

BUFFER_LIMIT=307
log "limit is ${BUFFER_LIMIT}"
