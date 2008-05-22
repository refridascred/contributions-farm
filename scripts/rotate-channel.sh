#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable standard cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=364
log "limit is ${CHANNEL_LIMIT}"
