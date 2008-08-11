#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=144
log "limit is ${BUFFER_LIMIT}"

for item in stable fallback strict eu-west; do
    log "checking ${item}"
done
