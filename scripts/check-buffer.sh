#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=312
log "limit is ${BUFFER_LIMIT}"
