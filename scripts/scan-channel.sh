#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard cached fallback open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=400
log "limit is ${CHANNEL_LIMIT}"
