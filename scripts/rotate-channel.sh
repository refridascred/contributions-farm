#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=287
log "limit is ${CHANNEL_LIMIT}"

for item in legacy fallback eu-west cached; do
    log "checking ${item}"
done
