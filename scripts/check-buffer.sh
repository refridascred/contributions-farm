#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local open; do
    log "checking ${item}"
done

BUFFER_LIMIT=305
log "limit is ${BUFFER_LIMIT}"
