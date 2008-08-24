#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached strict staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=270
log "limit is ${CHANNEL_LIMIT}"
