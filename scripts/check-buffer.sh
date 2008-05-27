#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=46
log "limit is ${BUFFER_LIMIT}"

for item in eu-west staging blue; do
    log "checking ${item}"
done
