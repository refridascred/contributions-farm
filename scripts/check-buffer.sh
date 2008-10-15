#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue local stable standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=314
log "limit is ${BUFFER_LIMIT}"
