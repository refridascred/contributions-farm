#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary blue edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=91
log "limit is ${CHANNEL_LIMIT}"
