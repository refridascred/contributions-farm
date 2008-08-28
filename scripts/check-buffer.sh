#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=467
log "limit is ${BUFFER_LIMIT}"

for item in latest legacy fallback green; do
    log "checking ${item}"
done
