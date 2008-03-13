#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=220
log "limit is ${CHANNEL_LIMIT}"

for item in edge primary blue stable; do
    log "checking ${item}"
done
