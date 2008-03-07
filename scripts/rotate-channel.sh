#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=338
log "limit is ${CHANNEL_LIMIT}"

for item in fallback stable eu-west local; do
    log "checking ${item}"
done
