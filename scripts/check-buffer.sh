#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=237
log "limit is ${BUFFER_LIMIT}"

for item in latest legacy local fallback; do
    log "checking ${item}"
done
