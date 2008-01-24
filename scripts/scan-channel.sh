#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict open legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=66
log "limit is ${CHANNEL_LIMIT}"
