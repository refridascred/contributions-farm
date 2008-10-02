#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy edge strict primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=387
log "limit is ${BUFFER_LIMIT}"
