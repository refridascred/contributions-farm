#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=36
log "limit is ${BUFFER_LIMIT}"

for item in green legacy primary latest; do
    log "checking ${item}"
done
