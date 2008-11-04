#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue local standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=377
log "limit is ${BUFFER_LIMIT}"
