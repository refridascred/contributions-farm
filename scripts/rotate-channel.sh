#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable eu-west open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=355
log "limit is ${CHANNEL_LIMIT}"
