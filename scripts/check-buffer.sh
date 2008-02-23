#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green edge standard local; do
    log "checking ${item}"
done

BUFFER_LIMIT=291
log "limit is ${BUFFER_LIMIT}"
