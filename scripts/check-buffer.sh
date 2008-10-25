#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=377
log "limit is ${BUFFER_LIMIT}"
