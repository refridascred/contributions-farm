#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict blue legacy latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=144
log "limit is ${BUFFER_LIMIT}"
