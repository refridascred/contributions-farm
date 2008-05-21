#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=326
log "limit is ${CHANNEL_LIMIT}"
