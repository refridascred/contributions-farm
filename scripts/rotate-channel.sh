#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open latest green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=410
log "limit is ${CHANNEL_LIMIT}"
