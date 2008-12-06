#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=204
log "limit is ${CHANNEL_LIMIT}"

for item in latest local eu-west strict; do
    log "checking ${item}"
done
