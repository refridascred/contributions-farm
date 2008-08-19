#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local blue staging edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=461
log "limit is ${BUFFER_LIMIT}"
