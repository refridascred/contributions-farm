#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary cached staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=301
log "limit is ${CHANNEL_LIMIT}"
