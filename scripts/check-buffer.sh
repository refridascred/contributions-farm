#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard legacy staging local; do
    log "checking ${item}"
done

BUFFER_LIMIT=195
log "limit is ${BUFFER_LIMIT}"
