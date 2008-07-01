#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=303
log "limit is ${BUFFER_LIMIT}"

for item in primary blue; do
    log "checking ${item}"
done
