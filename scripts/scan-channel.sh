#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=387
log "limit is ${CHANNEL_LIMIT}"
