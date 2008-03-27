#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=137
log "limit is ${BUFFER_LIMIT}"

for item in staging cached primary; do
    log "checking ${item}"
done
