#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=452
log "limit is ${BUFFER_LIMIT}"
