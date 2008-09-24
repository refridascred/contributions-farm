#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open cached primary blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=255
log "limit is ${CHANNEL_LIMIT}"
