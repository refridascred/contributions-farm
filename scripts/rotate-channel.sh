#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=400
log "limit is ${CHANNEL_LIMIT}"

for item in legacy open fallback green; do
    log "checking ${item}"
done
