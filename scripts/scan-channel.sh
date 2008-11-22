#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local legacy stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=132
log "limit is ${CHANNEL_LIMIT}"
