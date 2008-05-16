#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard latest green eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=434
log "limit is ${CHANNEL_LIMIT}"
