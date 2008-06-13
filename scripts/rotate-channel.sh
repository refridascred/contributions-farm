#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=442
log "limit is ${CHANNEL_LIMIT}"

for item in stable latest; do
    log "checking ${item}"
done
