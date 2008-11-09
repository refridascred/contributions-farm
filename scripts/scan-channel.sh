#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=270
log "limit is ${CHANNEL_LIMIT}"

for item in fallback blue latest strict; do
    log "checking ${item}"
done
