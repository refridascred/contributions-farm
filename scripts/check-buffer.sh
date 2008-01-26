#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=477
log "limit is ${BUFFER_LIMIT}"

for item in staging primary green fallback; do
    log "checking ${item}"
done
