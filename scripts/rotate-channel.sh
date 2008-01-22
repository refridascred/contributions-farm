#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue edge fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=201
log "limit is ${CHANNEL_LIMIT}"
