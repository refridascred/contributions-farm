#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=470
log "limit is ${CHANNEL_LIMIT}"
