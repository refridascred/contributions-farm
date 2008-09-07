#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict stable standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=456
log "limit is ${CHANNEL_LIMIT}"
