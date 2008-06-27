#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=409
log "limit is ${CHANNEL_LIMIT}"

for item in primary latest legacy; do
    log "checking ${item}"
done
