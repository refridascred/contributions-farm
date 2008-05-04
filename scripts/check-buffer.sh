#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=110
log "limit is ${BUFFER_LIMIT}"

for item in staging cached local; do
    log "checking ${item}"
done
