#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary cached legacy open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=405
log "limit is ${CHANNEL_LIMIT}"
