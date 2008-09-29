#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=254
log "limit is ${CHANNEL_LIMIT}"

for item in blue fallback edge; do
    log "checking ${item}"
done
