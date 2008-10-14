#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable primary strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=340
log "limit is ${CHANNEL_LIMIT}"
