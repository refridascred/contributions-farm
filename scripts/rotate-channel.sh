#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=253
log "limit is ${CHANNEL_LIMIT}"

for item in stable local blue; do
    log "checking ${item}"
done
