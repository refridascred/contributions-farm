#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=213
log "limit is ${CHANNEL_LIMIT}"

for item in local strict; do
    log "checking ${item}"
done
