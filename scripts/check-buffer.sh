#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge cached staging open; do
    log "checking ${item}"
done

BUFFER_LIMIT=143
log "limit is ${BUFFER_LIMIT}"
