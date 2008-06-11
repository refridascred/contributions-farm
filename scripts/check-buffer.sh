#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging open blue primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=386
log "limit is ${BUFFER_LIMIT}"
