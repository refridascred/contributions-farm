#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=142
log "limit is ${BUFFER_LIMIT}"

for item in local eu-west standard blue; do
    log "checking ${item}"
done
