#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=463
log "limit is ${BUFFER_LIMIT}"

for item in fallback edge standard; do
    log "checking ${item}"
done
