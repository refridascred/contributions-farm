#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached blue strict primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=205
log "limit is ${CHANNEL_LIMIT}"
