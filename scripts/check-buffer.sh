#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict edge staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=295
log "limit is ${BUFFER_LIMIT}"
