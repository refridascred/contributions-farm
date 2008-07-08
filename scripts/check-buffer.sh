#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=115
log "limit is ${BUFFER_LIMIT}"

for item in green open staging edge; do
    log "checking ${item}"
done
