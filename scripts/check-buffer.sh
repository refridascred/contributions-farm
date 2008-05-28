#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard local fallback latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=451
log "limit is ${BUFFER_LIMIT}"
