#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy latest stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=70
log "limit is ${CHANNEL_LIMIT}"
