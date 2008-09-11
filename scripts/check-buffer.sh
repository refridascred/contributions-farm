#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge eu-west strict standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=426
log "limit is ${BUFFER_LIMIT}"
