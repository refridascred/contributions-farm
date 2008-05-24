#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=19
log "limit is ${CHANNEL_LIMIT}"

for item in latest strict blue; do
    log "checking ${item}"
done
