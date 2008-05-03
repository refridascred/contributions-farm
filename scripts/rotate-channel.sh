#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=260
log "limit is ${CHANNEL_LIMIT}"

for item in cached stable; do
    log "checking ${item}"
done
