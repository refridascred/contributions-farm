#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=468
log "limit is ${BUFFER_LIMIT}"

for item in eu-west staging open primary; do
    log "checking ${item}"
done
