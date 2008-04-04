#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard legacy eu-west blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=83
log "limit is ${CHANNEL_LIMIT}"
