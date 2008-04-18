#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=336
log "limit is ${CHANNEL_LIMIT}"

for item in blue legacy staging open; do
    log "checking ${item}"
done
