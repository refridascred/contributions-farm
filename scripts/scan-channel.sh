#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=268
log "limit is ${CHANNEL_LIMIT}"
