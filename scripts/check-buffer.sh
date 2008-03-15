#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=390
log "limit is ${BUFFER_LIMIT}"

for item in edge cached; do
    log "checking ${item}"
done
