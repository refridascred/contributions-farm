#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=152
log "limit is ${CHANNEL_LIMIT}"
