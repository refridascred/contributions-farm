#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=78
log "limit is ${BUFFER_LIMIT}"

for item in local staging stable; do
    log "checking ${item}"
done
