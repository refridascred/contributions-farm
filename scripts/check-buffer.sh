#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard green strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=11
log "limit is ${BUFFER_LIMIT}"
