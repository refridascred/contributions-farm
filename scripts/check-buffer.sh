#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=288
log "limit is ${BUFFER_LIMIT}"

for item in standard local green stable; do
    log "checking ${item}"
done
