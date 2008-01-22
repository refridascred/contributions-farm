#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest fallback standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=456
log "limit is ${CHANNEL_LIMIT}"
