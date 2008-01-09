#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=67
log "limit is ${CHANNEL_LIMIT}"

for item in local standard stable; do
    log "checking ${item}"
done
