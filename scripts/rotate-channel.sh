#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=52
log "limit is ${CHANNEL_LIMIT}"

for item in cached standard local; do
    log "checking ${item}"
done
