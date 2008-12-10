#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green legacy standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=134
log "limit is ${CHANNEL_LIMIT}"
