#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest edge blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=439
log "limit is ${CHANNEL_LIMIT}"
