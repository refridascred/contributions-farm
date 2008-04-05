#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=399
log "limit is ${CHANNEL_LIMIT}"

for item in latest legacy standard strict; do
    log "checking ${item}"
done
