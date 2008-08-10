#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=22
log "limit is ${CHANNEL_LIMIT}"

for item in cached blue open; do
    log "checking ${item}"
done
