#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=288
log "limit is ${BUFFER_LIMIT}"

for item in staging legacy open; do
    log "checking ${item}"
done
