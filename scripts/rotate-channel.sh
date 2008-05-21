#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable blue cached strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=261
log "limit is ${CHANNEL_LIMIT}"
