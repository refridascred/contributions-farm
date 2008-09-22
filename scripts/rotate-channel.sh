#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=389
log "limit is ${CHANNEL_LIMIT}"

for item in cached blue strict edge; do
    log "checking ${item}"
done
