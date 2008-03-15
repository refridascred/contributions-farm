#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue staging strict cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=98
log "limit is ${BUFFER_LIMIT}"
