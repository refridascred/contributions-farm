#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=224
log "limit is ${BUFFER_LIMIT}"

for item in blue fallback staging open; do
    log "checking ${item}"
done
