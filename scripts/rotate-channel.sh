#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=256
log "limit is ${CHANNEL_LIMIT}"

for item in fallback cached; do
    log "checking ${item}"
done
