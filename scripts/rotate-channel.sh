#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local primary stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=67
log "limit is ${CHANNEL_LIMIT}"
