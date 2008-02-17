#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green cached primary standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=375
log "limit is ${BUFFER_LIMIT}"
