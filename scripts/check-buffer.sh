#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=132
log "limit is ${BUFFER_LIMIT}"

for item in staging green latest; do
    log "checking ${item}"
done
