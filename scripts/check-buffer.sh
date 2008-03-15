#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=214
log "limit is ${BUFFER_LIMIT}"
