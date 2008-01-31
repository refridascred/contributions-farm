#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=285
log "limit is ${CHANNEL_LIMIT}"

for item in primary eu-west fallback stable; do
    log "checking ${item}"
done
