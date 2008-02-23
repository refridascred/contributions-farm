#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue edge green open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=347
log "limit is ${CHANNEL_LIMIT}"
