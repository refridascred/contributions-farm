#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green stable blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=58
log "limit is ${CHANNEL_LIMIT}"
