#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest edge standard legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=364
log "limit is ${CHANNEL_LIMIT}"
