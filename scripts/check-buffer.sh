#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=446
log "limit is ${BUFFER_LIMIT}"

for item in stable staging edge strict; do
    log "checking ${item}"
done
