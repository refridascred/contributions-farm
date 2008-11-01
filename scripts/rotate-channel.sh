#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open green fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=500
log "limit is ${CHANNEL_LIMIT}"
