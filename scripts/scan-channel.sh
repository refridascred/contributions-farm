#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue latest green strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=221
log "limit is ${CHANNEL_LIMIT}"
