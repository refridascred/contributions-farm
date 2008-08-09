#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=105
log "limit is ${CHANNEL_LIMIT}"

for item in staging blue; do
    log "checking ${item}"
done
