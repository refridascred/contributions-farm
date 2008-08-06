#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=239
log "limit is ${CHANNEL_LIMIT}"
