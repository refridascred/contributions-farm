#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=389
log "limit is ${BUFFER_LIMIT}"

for item in green standard primary; do
    log "checking ${item}"
done
