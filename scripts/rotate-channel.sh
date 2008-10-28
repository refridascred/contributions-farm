#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging open local blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=207
log "limit is ${CHANNEL_LIMIT}"
