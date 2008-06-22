#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=299
log "limit is ${CHANNEL_LIMIT}"

for item in local open fallback strict; do
    log "checking ${item}"
done
