#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=147
log "limit is ${BUFFER_LIMIT}"

for item in legacy eu-west green; do
    log "checking ${item}"
done
