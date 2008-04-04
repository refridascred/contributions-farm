#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=48
log "limit is ${CHANNEL_LIMIT}"

for item in strict cached; do
    log "checking ${item}"
done
