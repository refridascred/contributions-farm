#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=233
log "limit is ${CHANNEL_LIMIT}"

for item in standard cached blue edge; do
    log "checking ${item}"
done
