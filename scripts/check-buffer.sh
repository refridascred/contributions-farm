#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable open green blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=209
log "limit is ${BUFFER_LIMIT}"
