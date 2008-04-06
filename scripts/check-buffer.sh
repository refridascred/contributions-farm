#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=388
log "limit is ${BUFFER_LIMIT}"

for item in fallback latest eu-west; do
    log "checking ${item}"
done
