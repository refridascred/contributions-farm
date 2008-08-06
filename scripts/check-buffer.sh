#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west fallback open standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=185
log "limit is ${BUFFER_LIMIT}"
