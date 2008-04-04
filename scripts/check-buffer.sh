#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy local eu-west open; do
    log "checking ${item}"
done

BUFFER_LIMIT=321
log "limit is ${BUFFER_LIMIT}"
