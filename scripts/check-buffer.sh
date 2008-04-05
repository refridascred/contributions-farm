#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge green staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=358
log "limit is ${BUFFER_LIMIT}"
