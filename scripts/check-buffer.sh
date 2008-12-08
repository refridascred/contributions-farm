#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west edge primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=465
log "limit is ${BUFFER_LIMIT}"
