#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable edge local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=488
log "limit is ${CHANNEL_LIMIT}"
