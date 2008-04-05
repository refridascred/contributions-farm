#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=366
log "limit is ${BUFFER_LIMIT}"

for item in edge cached strict; do
    log "checking ${item}"
done
