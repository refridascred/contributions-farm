#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=228
log "limit is ${CHANNEL_LIMIT}"
