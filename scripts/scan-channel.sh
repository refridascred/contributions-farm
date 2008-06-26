#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=489
log "limit is ${CHANNEL_LIMIT}"

for item in latest blue; do
    log "checking ${item}"
done
