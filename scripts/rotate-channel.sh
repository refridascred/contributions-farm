#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=35
log "limit is ${CHANNEL_LIMIT}"

for item in cached stable green; do
    log "checking ${item}"
done
