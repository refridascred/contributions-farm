#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy staging open cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=90
log "limit is ${CHANNEL_LIMIT}"
