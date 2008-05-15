#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=126
log "limit is ${CHANNEL_LIMIT}"

for item in edge stable; do
    log "checking ${item}"
done
