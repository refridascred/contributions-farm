#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable cached fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=344
log "limit is ${CHANNEL_LIMIT}"
