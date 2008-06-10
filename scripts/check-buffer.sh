#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=401
log "limit is ${BUFFER_LIMIT}"

for item in cached edge staging latest; do
    log "checking ${item}"
done
