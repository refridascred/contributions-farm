#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge primary open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=424
log "limit is ${CHANNEL_LIMIT}"
