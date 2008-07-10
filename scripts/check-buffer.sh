#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=49
log "limit is ${BUFFER_LIMIT}"

for item in local eu-west cached; do
    log "checking ${item}"
done
