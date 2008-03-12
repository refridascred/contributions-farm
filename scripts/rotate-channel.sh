#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=146
log "limit is ${CHANNEL_LIMIT}"

for item in local primary eu-west open; do
    log "checking ${item}"
done
