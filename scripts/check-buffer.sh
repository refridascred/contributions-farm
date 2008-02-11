#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=404
log "limit is ${BUFFER_LIMIT}"

for item in eu-west fallback cached green; do
    log "checking ${item}"
done
