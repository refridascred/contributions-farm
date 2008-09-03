#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=368
log "limit is ${CHANNEL_LIMIT}"

for item in green open; do
    log "checking ${item}"
done
