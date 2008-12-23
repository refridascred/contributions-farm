#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=288
log "limit is ${CHANNEL_LIMIT}"

for item in local stable; do
    log "checking ${item}"
done
