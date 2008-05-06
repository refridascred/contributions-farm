#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west fallback edge cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=95
log "limit is ${BUFFER_LIMIT}"
