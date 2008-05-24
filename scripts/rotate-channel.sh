#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=433
log "limit is ${CHANNEL_LIMIT}"

for item in primary green eu-west; do
    log "checking ${item}"
done
