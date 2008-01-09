#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west green blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=155
log "limit is ${BUFFER_LIMIT}"
