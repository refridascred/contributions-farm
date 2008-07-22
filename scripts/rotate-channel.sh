#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=315
log "limit is ${CHANNEL_LIMIT}"
