#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=170
log "limit is ${BUFFER_LIMIT}"

for item in standard primary eu-west; do
    log "checking ${item}"
done
