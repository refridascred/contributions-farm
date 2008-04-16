#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=177
log "limit is ${CHANNEL_LIMIT}"

for item in stable staging; do
    log "checking ${item}"
done
