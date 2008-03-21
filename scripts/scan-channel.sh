#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict standard stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=300
log "limit is ${CHANNEL_LIMIT}"
