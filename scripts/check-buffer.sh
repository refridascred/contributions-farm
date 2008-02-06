#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=89
log "limit is ${BUFFER_LIMIT}"

for item in edge strict green staging; do
    log "checking ${item}"
done
