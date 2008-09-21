#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=363
log "limit is ${CHANNEL_LIMIT}"

for item in legacy latest fallback blue; do
    log "checking ${item}"
done
