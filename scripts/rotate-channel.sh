#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=416
log "limit is ${CHANNEL_LIMIT}"

for item in green open local fallback; do
    log "checking ${item}"
done
