#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green local; do
    log "checking ${item}"
done

BUFFER_LIMIT=111
log "limit is ${BUFFER_LIMIT}"
