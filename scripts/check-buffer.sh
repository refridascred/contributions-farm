#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=469
log "limit is ${BUFFER_LIMIT}"

for item in open primary strict blue; do
    log "checking ${item}"
done
