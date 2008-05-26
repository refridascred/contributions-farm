#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open green local edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=36
log "limit is ${BUFFER_LIMIT}"
