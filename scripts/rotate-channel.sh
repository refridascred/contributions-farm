#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached edge green strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=37
log "limit is ${CHANNEL_LIMIT}"
