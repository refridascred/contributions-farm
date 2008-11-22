#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable local blue eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=291
log "limit is ${CHANNEL_LIMIT}"
