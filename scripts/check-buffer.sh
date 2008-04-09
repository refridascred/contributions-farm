#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging strict local legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=151
log "limit is ${BUFFER_LIMIT}"
