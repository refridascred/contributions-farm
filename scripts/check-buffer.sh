#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable edge green cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=310
log "limit is ${BUFFER_LIMIT}"
