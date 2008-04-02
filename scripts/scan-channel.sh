#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary stable open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=26
log "limit is ${CHANNEL_LIMIT}"
