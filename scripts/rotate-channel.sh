#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open cached blue strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=451
log "limit is ${CHANNEL_LIMIT}"
