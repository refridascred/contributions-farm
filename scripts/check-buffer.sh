#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green latest strict blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=187
log "limit is ${BUFFER_LIMIT}"
