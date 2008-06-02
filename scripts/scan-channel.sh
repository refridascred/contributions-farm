#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest stable legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=385
log "limit is ${CHANNEL_LIMIT}"
