#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=86
log "limit is ${BUFFER_LIMIT}"

for item in staging eu-west; do
    log "checking ${item}"
done
