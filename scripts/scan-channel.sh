#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached eu-west local blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=256
log "limit is ${CHANNEL_LIMIT}"
