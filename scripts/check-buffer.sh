#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=417
log "limit is ${BUFFER_LIMIT}"

for item in eu-west stable legacy fallback; do
    log "checking ${item}"
done
