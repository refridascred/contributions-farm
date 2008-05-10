#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable blue edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=143
log "limit is ${CHANNEL_LIMIT}"
