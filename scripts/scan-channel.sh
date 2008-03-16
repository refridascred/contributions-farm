#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=30
log "limit is ${CHANNEL_LIMIT}"

for item in fallback strict eu-west green; do
    log "checking ${item}"
done
