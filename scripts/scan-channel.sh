#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=237
log "limit is ${CHANNEL_LIMIT}"

for item in open legacy green local; do
    log "checking ${item}"
done
