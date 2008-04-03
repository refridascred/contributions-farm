#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open blue primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=369
log "limit is ${BUFFER_LIMIT}"
