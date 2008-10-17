#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=129
log "limit is ${BUFFER_LIMIT}"

for item in legacy local; do
    log "checking ${item}"
done
