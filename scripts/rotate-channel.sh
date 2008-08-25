#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable eu-west legacy staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=293
log "limit is ${CHANNEL_LIMIT}"
