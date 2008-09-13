#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=205
log "limit is ${BUFFER_LIMIT}"

for item in latest staging primary standard; do
    log "checking ${item}"
done
