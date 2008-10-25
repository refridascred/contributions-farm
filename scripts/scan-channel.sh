#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green open legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=183
log "limit is ${CHANNEL_LIMIT}"
