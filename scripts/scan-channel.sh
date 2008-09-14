#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard blue stable open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=466
log "limit is ${CHANNEL_LIMIT}"
