#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy latest open local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=252
log "limit is ${CHANNEL_LIMIT}"
