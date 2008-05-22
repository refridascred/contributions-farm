#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green stable primary edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=482
log "limit is ${BUFFER_LIMIT}"
