#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=304
log "limit is ${BUFFER_LIMIT}"
