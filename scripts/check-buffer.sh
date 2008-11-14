#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=118
log "limit is ${BUFFER_LIMIT}"

for item in eu-west open latest; do
    log "checking ${item}"
done
