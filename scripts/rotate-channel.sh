#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict open blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=251
log "limit is ${CHANNEL_LIMIT}"
