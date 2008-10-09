#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=330
log "limit is ${CHANNEL_LIMIT}"

for item in blue open; do
    log "checking ${item}"
done
