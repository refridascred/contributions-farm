#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary edge blue staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=115
log "limit is ${BUFFER_LIMIT}"
