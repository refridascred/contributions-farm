#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=300
log "limit is ${BUFFER_LIMIT}"

for item in fallback green eu-west; do
    log "checking ${item}"
done
