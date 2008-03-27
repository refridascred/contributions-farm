#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=271
log "limit is ${CHANNEL_LIMIT}"

for item in fallback edge blue; do
    log "checking ${item}"
done
