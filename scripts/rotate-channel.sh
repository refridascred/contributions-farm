#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green cached legacy stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=5
log "limit is ${CHANNEL_LIMIT}"
