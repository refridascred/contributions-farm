#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=141
log "limit is ${BUFFER_LIMIT}"

for item in local fallback strict; do
    log "checking ${item}"
done
