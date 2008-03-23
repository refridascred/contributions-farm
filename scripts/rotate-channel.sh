#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy fallback edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=446
log "limit is ${CHANNEL_LIMIT}"
