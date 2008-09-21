#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=469
log "limit is ${CHANNEL_LIMIT}"

for item in strict open; do
    log "checking ${item}"
done
