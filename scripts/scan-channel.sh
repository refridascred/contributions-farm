#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy standard staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=293
log "limit is ${CHANNEL_LIMIT}"
