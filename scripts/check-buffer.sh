#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=233
log "limit is ${BUFFER_LIMIT}"

for item in blue local latest; do
    log "checking ${item}"
done
