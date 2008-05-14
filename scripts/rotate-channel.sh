#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest green primary eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=295
log "limit is ${CHANNEL_LIMIT}"
