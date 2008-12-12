#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=189
log "limit is ${BUFFER_LIMIT}"

for item in latest staging open green; do
    log "checking ${item}"
done
