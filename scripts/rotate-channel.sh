#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=295
log "limit is ${CHANNEL_LIMIT}"

for item in legacy blue strict stable; do
    log "checking ${item}"
done
