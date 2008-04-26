#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached eu-west latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=332
log "limit is ${BUFFER_LIMIT}"
