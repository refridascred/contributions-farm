#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=228
log "limit is ${BUFFER_LIMIT}"
