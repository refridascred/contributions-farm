#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=81
log "limit is ${CHANNEL_LIMIT}"

for item in legacy open; do
    log "checking ${item}"
done
