#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=114
log "limit is ${CHANNEL_LIMIT}"
