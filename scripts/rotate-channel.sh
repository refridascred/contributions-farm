#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=418
log "limit is ${CHANNEL_LIMIT}"

for item in strict blue; do
    log "checking ${item}"
done
