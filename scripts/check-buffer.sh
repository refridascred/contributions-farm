#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=234
log "limit is ${BUFFER_LIMIT}"

for item in open edge primary; do
    log "checking ${item}"
done
