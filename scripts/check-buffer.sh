#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=48
log "limit is ${BUFFER_LIMIT}"

for item in latest eu-west primary edge; do
    log "checking ${item}"
done
