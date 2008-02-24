#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=398
log "limit is ${BUFFER_LIMIT}"

for item in standard blue local fallback; do
    log "checking ${item}"
done
