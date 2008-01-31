#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy staging blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=344
log "limit is ${CHANNEL_LIMIT}"
