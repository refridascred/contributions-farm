#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=266
log "limit is ${CHANNEL_LIMIT}"

for item in stable open strict local; do
    log "checking ${item}"
done
