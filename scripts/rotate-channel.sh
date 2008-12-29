#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=265
log "limit is ${CHANNEL_LIMIT}"

for item in strict staging local; do
    log "checking ${item}"
done
