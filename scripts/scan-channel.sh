#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback blue strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=338
log "limit is ${CHANNEL_LIMIT}"
