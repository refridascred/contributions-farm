#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=61
log "limit is ${BUFFER_LIMIT}"

for item in eu-west open local; do
    log "checking ${item}"
done
