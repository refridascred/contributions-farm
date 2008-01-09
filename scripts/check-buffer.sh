#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=399
log "limit is ${BUFFER_LIMIT}"

for item in local standard; do
    log "checking ${item}"
done
