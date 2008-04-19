#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=234
log "limit is ${CHANNEL_LIMIT}"

for item in strict cached legacy open; do
    log "checking ${item}"
done
