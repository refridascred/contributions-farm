#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=114
log "limit is ${BUFFER_LIMIT}"

for item in latest edge; do
    log "checking ${item}"
done
