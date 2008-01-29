#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=180
log "limit is ${CHANNEL_LIMIT}"

for item in open cached edge local; do
    log "checking ${item}"
done
