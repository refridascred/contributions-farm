#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=155
log "limit is ${CHANNEL_LIMIT}"
