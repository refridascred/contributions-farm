#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west stable legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=444
log "limit is ${BUFFER_LIMIT}"
