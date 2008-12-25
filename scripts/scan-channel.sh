#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=145
log "limit is ${CHANNEL_LIMIT}"

for item in stable blue strict; do
    log "checking ${item}"
done
