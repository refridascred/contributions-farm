#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=49
log "limit is ${CHANNEL_LIMIT}"
