#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=240
log "limit is ${BUFFER_LIMIT}"

for item in primary open; do
    log "checking ${item}"
done
