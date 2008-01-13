#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=62
log "limit is ${BUFFER_LIMIT}"

for item in edge fallback; do
    log "checking ${item}"
done
