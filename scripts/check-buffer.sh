#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=437
log "limit is ${BUFFER_LIMIT}"

for item in eu-west standard; do
    log "checking ${item}"
done
