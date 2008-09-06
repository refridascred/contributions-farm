#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=379
log "limit is ${CHANNEL_LIMIT}"

for item in cached green fallback; do
    log "checking ${item}"
done
