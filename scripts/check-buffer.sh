#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue primary standard edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=200
log "limit is ${BUFFER_LIMIT}"
