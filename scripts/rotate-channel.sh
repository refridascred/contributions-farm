#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary stable blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=204
log "limit is ${CHANNEL_LIMIT}"
