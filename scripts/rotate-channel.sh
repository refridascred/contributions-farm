#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge standard stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=379
log "limit is ${CHANNEL_LIMIT}"
