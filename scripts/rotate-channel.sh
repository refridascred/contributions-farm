#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=144
log "limit is ${CHANNEL_LIMIT}"

for item in fallback eu-west open cached; do
    log "checking ${item}"
done
