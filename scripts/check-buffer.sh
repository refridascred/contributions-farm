#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=477
log "limit is ${BUFFER_LIMIT}"

for item in green blue staging; do
    log "checking ${item}"
done
