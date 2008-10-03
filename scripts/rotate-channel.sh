#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=80
log "limit is ${CHANNEL_LIMIT}"

for item in latest green blue; do
    log "checking ${item}"
done
