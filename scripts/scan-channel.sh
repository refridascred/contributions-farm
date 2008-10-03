#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=117
log "limit is ${CHANNEL_LIMIT}"

for item in latest staging cached; do
    log "checking ${item}"
done
