#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=402
log "limit is ${BUFFER_LIMIT}"

for item in cached staging standard latest; do
    log "checking ${item}"
done
