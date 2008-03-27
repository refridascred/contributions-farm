#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=124
log "limit is ${CHANNEL_LIMIT}"
