#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=301
log "limit is ${CHANNEL_LIMIT}"

for item in local fallback open eu-west; do
    log "checking ${item}"
done
