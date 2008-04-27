#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary green stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=143
log "limit is ${CHANNEL_LIMIT}"
