#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west blue strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=122
log "limit is ${BUFFER_LIMIT}"
