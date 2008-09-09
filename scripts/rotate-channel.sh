#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=84
log "limit is ${CHANNEL_LIMIT}"

for item in cached edge blue; do
    log "checking ${item}"
done
