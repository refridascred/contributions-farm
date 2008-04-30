#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=132
log "limit is ${CHANNEL_LIMIT}"
