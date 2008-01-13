#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=74
log "limit is ${CHANNEL_LIMIT}"

for item in cached fallback blue; do
    log "checking ${item}"
done
