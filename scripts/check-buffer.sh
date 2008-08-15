#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue standard strict eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=313
log "limit is ${BUFFER_LIMIT}"
