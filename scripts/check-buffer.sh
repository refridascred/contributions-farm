#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=20
log "limit is ${BUFFER_LIMIT}"
