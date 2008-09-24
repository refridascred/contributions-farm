#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=450
log "limit is ${BUFFER_LIMIT}"

for item in local edge legacy staging; do
    log "checking ${item}"
done
