#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=16
log "limit is ${BUFFER_LIMIT}"

for item in primary strict local; do
    log "checking ${item}"
done
