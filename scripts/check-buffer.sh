#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=495
log "limit is ${BUFFER_LIMIT}"

for item in strict fallback cached legacy; do
    log "checking ${item}"
done
