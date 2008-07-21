#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=422
log "limit is ${BUFFER_LIMIT}"

for item in eu-west strict primary open; do
    log "checking ${item}"
done
