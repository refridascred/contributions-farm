#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=494
log "limit is ${BUFFER_LIMIT}"

for item in stable latest staging primary; do
    log "checking ${item}"
done
