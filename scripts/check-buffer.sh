#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=392
log "limit is ${BUFFER_LIMIT}"

for item in standard primary legacy local; do
    log "checking ${item}"
done
