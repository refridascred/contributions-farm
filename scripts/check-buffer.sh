#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard strict legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=413
log "limit is ${BUFFER_LIMIT}"
