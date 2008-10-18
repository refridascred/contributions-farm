#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable primary open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=403
log "limit is ${CHANNEL_LIMIT}"
