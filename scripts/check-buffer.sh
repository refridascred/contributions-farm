#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=294
log "limit is ${BUFFER_LIMIT}"

for item in stable fallback; do
    log "checking ${item}"
done
