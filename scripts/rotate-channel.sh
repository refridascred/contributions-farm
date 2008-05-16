#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=374
log "limit is ${CHANNEL_LIMIT}"
