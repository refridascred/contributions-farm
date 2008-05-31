#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest green blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=297
log "limit is ${CHANNEL_LIMIT}"
