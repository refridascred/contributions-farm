#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue staging local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=444
log "limit is ${CHANNEL_LIMIT}"
