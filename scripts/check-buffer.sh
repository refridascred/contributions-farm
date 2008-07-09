#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback edge cached primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=243
log "limit is ${BUFFER_LIMIT}"
