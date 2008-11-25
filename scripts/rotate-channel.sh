#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green latest local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=190
log "limit is ${CHANNEL_LIMIT}"
