#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=387
log "limit is ${BUFFER_LIMIT}"

for item in fallback stable blue standard; do
    log "checking ${item}"
done
