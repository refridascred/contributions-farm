#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=348
log "limit is ${BUFFER_LIMIT}"

for item in standard staging fallback; do
    log "checking ${item}"
done
