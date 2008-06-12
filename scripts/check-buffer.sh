#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=71
log "limit is ${BUFFER_LIMIT}"

for item in staging blue legacy; do
    log "checking ${item}"
done
