#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=152
log "limit is ${CHANNEL_LIMIT}"
