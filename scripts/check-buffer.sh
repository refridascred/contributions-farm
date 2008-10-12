#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=117
log "limit is ${BUFFER_LIMIT}"

for item in staging standard; do
    log "checking ${item}"
done
