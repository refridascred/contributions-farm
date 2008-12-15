#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=398
log "limit is ${CHANNEL_LIMIT}"

for item in local blue; do
    log "checking ${item}"
done
