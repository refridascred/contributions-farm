#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=296
log "limit is ${BUFFER_LIMIT}"
