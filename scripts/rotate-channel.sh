#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict green cached eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=372
log "limit is ${CHANNEL_LIMIT}"
