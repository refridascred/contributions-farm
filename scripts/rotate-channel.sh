#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=66
log "limit is ${CHANNEL_LIMIT}"

for item in stable green fallback standard; do
    log "checking ${item}"
done
