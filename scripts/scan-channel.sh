#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary local cached legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=12
log "limit is ${CHANNEL_LIMIT}"
