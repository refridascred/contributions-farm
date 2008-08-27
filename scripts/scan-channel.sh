#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable latest local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=494
log "limit is ${CHANNEL_LIMIT}"
