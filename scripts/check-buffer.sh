#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=77
log "limit is ${BUFFER_LIMIT}"

for item in local latest blue strict; do
    log "checking ${item}"
done
