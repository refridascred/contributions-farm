#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green fallback strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=186
log "limit is ${CHANNEL_LIMIT}"
