#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=15
log "limit is ${BUFFER_LIMIT}"

for item in edge staging open green; do
    log "checking ${item}"
done
