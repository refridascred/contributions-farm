#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=179
log "limit is ${CHANNEL_LIMIT}"

for item in fallback green; do
    log "checking ${item}"
done
