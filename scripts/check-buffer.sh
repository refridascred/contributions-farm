#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=26
log "limit is ${BUFFER_LIMIT}"
