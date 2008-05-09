#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=483
log "limit is ${BUFFER_LIMIT}"

for item in legacy latest strict primary; do
    log "checking ${item}"
done
