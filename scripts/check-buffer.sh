#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=264
log "limit is ${BUFFER_LIMIT}"

for item in eu-west local edge standard; do
    log "checking ${item}"
done
