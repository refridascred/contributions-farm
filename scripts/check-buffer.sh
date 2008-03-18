#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open stable legacy latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=259
log "limit is ${BUFFER_LIMIT}"
