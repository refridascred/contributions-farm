#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=126
log "limit is ${BUFFER_LIMIT}"

for item in legacy green; do
    log "checking ${item}"
done
