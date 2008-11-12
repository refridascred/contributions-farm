#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging legacy open green; do
    log "checking ${item}"
done

BUFFER_LIMIT=358
log "limit is ${BUFFER_LIMIT}"
