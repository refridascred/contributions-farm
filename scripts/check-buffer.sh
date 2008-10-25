#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable latest primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=438
log "limit is ${BUFFER_LIMIT}"
