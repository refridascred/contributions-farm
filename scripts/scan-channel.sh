#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue standard staging cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=155
log "limit is ${CHANNEL_LIMIT}"
