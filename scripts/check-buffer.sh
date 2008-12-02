#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=457
log "limit is ${BUFFER_LIMIT}"

for item in cached green edge strict; do
    log "checking ${item}"
done
