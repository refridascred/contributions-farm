#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=75
log "limit is ${CHANNEL_LIMIT}"

for item in fallback eu-west edge; do
    log "checking ${item}"
done
