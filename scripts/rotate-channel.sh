#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy edge stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=496
log "limit is ${CHANNEL_LIMIT}"
