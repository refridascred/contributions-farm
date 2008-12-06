#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=16
log "limit is ${CHANNEL_LIMIT}"

for item in staging strict open; do
    log "checking ${item}"
done
