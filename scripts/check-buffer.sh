#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=428
log "limit is ${BUFFER_LIMIT}"

for item in local standard blue primary; do
    log "checking ${item}"
done
