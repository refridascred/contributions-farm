#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=273
log "limit is ${BUFFER_LIMIT}"

for item in edge fallback stable legacy; do
    log "checking ${item}"
done
