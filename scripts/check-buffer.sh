#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue standard green eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=220
log "limit is ${BUFFER_LIMIT}"
