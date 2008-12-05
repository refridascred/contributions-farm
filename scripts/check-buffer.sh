#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=463
log "limit is ${BUFFER_LIMIT}"
