#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached blue legacy staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=351
log "limit is ${CHANNEL_LIMIT}"
