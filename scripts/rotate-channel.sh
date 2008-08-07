#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest staging open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=285
log "limit is ${CHANNEL_LIMIT}"
