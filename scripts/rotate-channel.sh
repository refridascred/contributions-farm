#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary staging eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=48
log "limit is ${CHANNEL_LIMIT}"
