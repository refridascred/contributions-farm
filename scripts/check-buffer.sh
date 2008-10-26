#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=421
log "limit is ${BUFFER_LIMIT}"

for item in fallback standard legacy; do
    log "checking ${item}"
done
