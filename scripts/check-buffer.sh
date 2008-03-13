#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=92
log "limit is ${BUFFER_LIMIT}"

for item in standard cached; do
    log "checking ${item}"
done
