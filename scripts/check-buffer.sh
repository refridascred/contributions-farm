#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=236
log "limit is ${BUFFER_LIMIT}"

for item in latest standard primary; do
    log "checking ${item}"
done
