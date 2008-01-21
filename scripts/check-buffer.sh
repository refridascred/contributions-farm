#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=51
log "limit is ${BUFFER_LIMIT}"

for item in local latest primary edge; do
    log "checking ${item}"
done
