#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open strict primary standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=416
log "limit is ${BUFFER_LIMIT}"
