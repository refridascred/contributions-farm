#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=285
log "limit is ${BUFFER_LIMIT}"
