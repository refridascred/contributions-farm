#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=63
log "limit is ${CHANNEL_LIMIT}"

for item in legacy green open staging; do
    log "checking ${item}"
done
