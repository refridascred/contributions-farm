#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=81
log "limit is ${BUFFER_LIMIT}"

for item in staging eu-west stable; do
    log "checking ${item}"
done
