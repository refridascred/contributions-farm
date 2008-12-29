#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=100
log "limit is ${CHANNEL_LIMIT}"
