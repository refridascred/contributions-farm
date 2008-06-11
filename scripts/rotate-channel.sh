#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=274
log "limit is ${CHANNEL_LIMIT}"
