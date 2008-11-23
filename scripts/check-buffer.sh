#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=432
log "limit is ${BUFFER_LIMIT}"

for item in green eu-west primary open; do
    log "checking ${item}"
done
