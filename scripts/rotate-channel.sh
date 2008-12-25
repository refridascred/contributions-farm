#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy open eu-west stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=265
log "limit is ${CHANNEL_LIMIT}"
