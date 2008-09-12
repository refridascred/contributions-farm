#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local open green; do
    log "checking ${item}"
done

BUFFER_LIMIT=120
log "limit is ${BUFFER_LIMIT}"
