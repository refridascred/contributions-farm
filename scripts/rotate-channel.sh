#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=180
log "limit is ${CHANNEL_LIMIT}"

for item in standard staging local; do
    log "checking ${item}"
done
