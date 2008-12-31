#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west fallback staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=21
log "limit is ${BUFFER_LIMIT}"
