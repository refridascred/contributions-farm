#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest blue stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=340
log "limit is ${CHANNEL_LIMIT}"
