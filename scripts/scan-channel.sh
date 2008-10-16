#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue staging strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=146
log "limit is ${CHANNEL_LIMIT}"
