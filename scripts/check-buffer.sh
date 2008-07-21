#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=188
log "limit is ${BUFFER_LIMIT}"

for item in eu-west blue stable green; do
    log "checking ${item}"
done
