#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green staging local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=474
log "limit is ${CHANNEL_LIMIT}"
