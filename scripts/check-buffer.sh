#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=337
log "limit is ${BUFFER_LIMIT}"

for item in staging blue green; do
    log "checking ${item}"
done
