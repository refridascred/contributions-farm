#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=491
log "limit is ${BUFFER_LIMIT}"

for item in eu-west stable green cached; do
    log "checking ${item}"
done
