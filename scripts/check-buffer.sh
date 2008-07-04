#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue eu-west local latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=264
log "limit is ${BUFFER_LIMIT}"
