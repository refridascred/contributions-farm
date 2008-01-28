#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=438
log "limit is ${BUFFER_LIMIT}"

for item in fallback primary; do
    log "checking ${item}"
done
