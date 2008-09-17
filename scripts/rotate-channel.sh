#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=280
log "limit is ${CHANNEL_LIMIT}"

for item in green eu-west cached open; do
    log "checking ${item}"
done
