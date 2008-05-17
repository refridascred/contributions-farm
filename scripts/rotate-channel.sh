#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict green local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=342
log "limit is ${CHANNEL_LIMIT}"
