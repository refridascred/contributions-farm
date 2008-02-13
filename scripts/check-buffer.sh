#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=6
log "limit is ${BUFFER_LIMIT}"

for item in latest green edge strict; do
    log "checking ${item}"
done
