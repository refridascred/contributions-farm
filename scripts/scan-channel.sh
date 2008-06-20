#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=158
log "limit is ${CHANNEL_LIMIT}"
