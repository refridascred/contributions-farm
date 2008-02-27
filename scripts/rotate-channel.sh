#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging local fallback eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=264
log "limit is ${CHANNEL_LIMIT}"
