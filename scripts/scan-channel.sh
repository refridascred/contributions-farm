#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=326
log "limit is ${CHANNEL_LIMIT}"

for item in fallback primary local; do
    log "checking ${item}"
done
