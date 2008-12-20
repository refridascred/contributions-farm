#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local latest standard open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=486
log "limit is ${CHANNEL_LIMIT}"
