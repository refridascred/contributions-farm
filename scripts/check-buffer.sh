#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict open stable primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=13
log "limit is ${BUFFER_LIMIT}"
