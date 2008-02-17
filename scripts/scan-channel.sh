#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=127
log "limit is ${CHANNEL_LIMIT}"
