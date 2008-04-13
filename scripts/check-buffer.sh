#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest cached primary blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=245
log "limit is ${BUFFER_LIMIT}"
