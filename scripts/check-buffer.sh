#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=68
log "limit is ${BUFFER_LIMIT}"

for item in stable green open; do
    log "checking ${item}"
done
