#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=377
log "limit is ${BUFFER_LIMIT}"

for item in edge open; do
    log "checking ${item}"
done
