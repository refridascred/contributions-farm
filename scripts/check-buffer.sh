#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=76
log "limit is ${BUFFER_LIMIT}"

for item in blue cached standard open; do
    log "checking ${item}"
done
