#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard eu-west fallback blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=388
log "limit is ${BUFFER_LIMIT}"
