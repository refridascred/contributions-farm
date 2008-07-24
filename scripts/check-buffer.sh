#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west latest blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=137
log "limit is ${BUFFER_LIMIT}"
