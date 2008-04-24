#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=334
log "limit is ${BUFFER_LIMIT}"

for item in legacy stable edge cached; do
    log "checking ${item}"
done
