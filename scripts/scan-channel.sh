#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=189
log "limit is ${CHANNEL_LIMIT}"

for item in primary local stable cached; do
    log "checking ${item}"
done
