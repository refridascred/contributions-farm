#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=213
log "limit is ${BUFFER_LIMIT}"
