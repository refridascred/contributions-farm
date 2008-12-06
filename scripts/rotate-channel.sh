#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=435
log "limit is ${CHANNEL_LIMIT}"

for item in latest edge green fallback; do
    log "checking ${item}"
done
