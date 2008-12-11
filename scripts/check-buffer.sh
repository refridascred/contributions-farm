#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=390
log "limit is ${BUFFER_LIMIT}"

for item in primary open eu-west fallback; do
    log "checking ${item}"
done
