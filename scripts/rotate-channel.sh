#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached local stable open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=93
log "limit is ${CHANNEL_LIMIT}"
