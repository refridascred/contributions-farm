#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=83
log "limit is ${BUFFER_LIMIT}"

for item in fallback staging; do
    log "checking ${item}"
done
