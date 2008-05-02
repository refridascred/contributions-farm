#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=134
log "limit is ${BUFFER_LIMIT}"

for item in blue stable fallback standard; do
    log "checking ${item}"
done
