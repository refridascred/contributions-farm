#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=465
log "limit is ${BUFFER_LIMIT}"

for item in staging open standard primary; do
    log "checking ${item}"
done
