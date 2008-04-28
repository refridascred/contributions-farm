#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=458
log "limit is ${BUFFER_LIMIT}"

for item in latest staging eu-west open; do
    log "checking ${item}"
done
