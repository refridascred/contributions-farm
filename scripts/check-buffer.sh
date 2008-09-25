#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open local latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=430
log "limit is ${BUFFER_LIMIT}"
