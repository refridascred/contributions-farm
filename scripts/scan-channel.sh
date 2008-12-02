#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=391
log "limit is ${CHANNEL_LIMIT}"

for item in local green strict open; do
    log "checking ${item}"
done
