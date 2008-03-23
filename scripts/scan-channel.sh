#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary open eu-west stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=500
log "limit is ${CHANNEL_LIMIT}"
