#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=378
log "limit is ${CHANNEL_LIMIT}"
