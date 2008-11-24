#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=422
log "limit is ${CHANNEL_LIMIT}"

for item in green staging cached; do
    log "checking ${item}"
done
