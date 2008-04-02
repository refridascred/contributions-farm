#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=123
log "limit is ${CHANNEL_LIMIT}"

for item in latest staging; do
    log "checking ${item}"
done
