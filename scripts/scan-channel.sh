#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local primary cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=440
log "limit is ${CHANNEL_LIMIT}"
