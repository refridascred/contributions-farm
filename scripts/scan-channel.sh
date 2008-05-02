#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict staging blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=22
log "limit is ${CHANNEL_LIMIT}"
