#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=311
log "limit is ${BUFFER_LIMIT}"

for item in strict legacy latest stable; do
    log "checking ${item}"
done
