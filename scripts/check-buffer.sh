#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest cached open; do
    log "checking ${item}"
done

BUFFER_LIMIT=52
log "limit is ${BUFFER_LIMIT}"
