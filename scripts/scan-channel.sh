#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=195
log "limit is ${CHANNEL_LIMIT}"
