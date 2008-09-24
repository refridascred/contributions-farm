#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=243
log "limit is ${BUFFER_LIMIT}"

for item in legacy primary; do
    log "checking ${item}"
done
