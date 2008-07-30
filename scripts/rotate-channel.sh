#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=251
log "limit is ${CHANNEL_LIMIT}"

for item in blue edge stable local; do
    log "checking ${item}"
done
