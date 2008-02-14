#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=280
log "limit is ${CHANNEL_LIMIT}"
