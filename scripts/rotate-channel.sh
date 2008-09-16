#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green eu-west edge primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=254
log "limit is ${CHANNEL_LIMIT}"
