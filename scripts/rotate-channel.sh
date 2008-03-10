#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge staging strict blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=32
log "limit is ${CHANNEL_LIMIT}"
