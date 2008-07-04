#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=293
log "limit is ${BUFFER_LIMIT}"

for item in standard latest primary; do
    log "checking ${item}"
done
