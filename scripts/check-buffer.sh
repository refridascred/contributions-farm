#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=371
log "limit is ${BUFFER_LIMIT}"

for item in eu-west cached local; do
    log "checking ${item}"
done
