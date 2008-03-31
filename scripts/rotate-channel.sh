#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue eu-west cached local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=472
log "limit is ${CHANNEL_LIMIT}"
