#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict staging fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=457
log "limit is ${CHANNEL_LIMIT}"
