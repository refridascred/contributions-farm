#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest primary eu-west local; do
    log "checking ${item}"
done

BUFFER_LIMIT=388
log "limit is ${BUFFER_LIMIT}"
