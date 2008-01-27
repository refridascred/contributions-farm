#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=151
log "limit is ${BUFFER_LIMIT}"

for item in stable strict; do
    log "checking ${item}"
done
