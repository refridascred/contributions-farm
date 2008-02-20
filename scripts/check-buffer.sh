#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback legacy strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=102
log "limit is ${BUFFER_LIMIT}"
