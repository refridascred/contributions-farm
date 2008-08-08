#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict cached green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=7
log "limit is ${CHANNEL_LIMIT}"
