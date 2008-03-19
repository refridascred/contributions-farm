#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=252
log "limit is ${CHANNEL_LIMIT}"

for item in standard cached open; do
    log "checking ${item}"
done
