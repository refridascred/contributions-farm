#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary edge eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=126
log "limit is ${BUFFER_LIMIT}"
