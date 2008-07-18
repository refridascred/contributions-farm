#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=466
log "limit is ${CHANNEL_LIMIT}"

for item in legacy blue edge; do
    log "checking ${item}"
done
