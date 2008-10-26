#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest open cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=34
log "limit is ${CHANNEL_LIMIT}"
