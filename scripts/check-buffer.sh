#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary edge standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=51
log "limit is ${BUFFER_LIMIT}"
