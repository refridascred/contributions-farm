#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary fallback blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=148
log "limit is ${CHANNEL_LIMIT}"
