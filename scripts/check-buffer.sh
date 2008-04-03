#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest blue primary strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=288
log "limit is ${BUFFER_LIMIT}"
