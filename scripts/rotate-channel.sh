#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable blue local fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=222
log "limit is ${CHANNEL_LIMIT}"
