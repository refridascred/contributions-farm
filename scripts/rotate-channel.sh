#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest legacy eu-west strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=442
log "limit is ${CHANNEL_LIMIT}"
