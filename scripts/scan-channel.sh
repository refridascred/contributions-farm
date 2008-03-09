#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=226
log "limit is ${CHANNEL_LIMIT}"
