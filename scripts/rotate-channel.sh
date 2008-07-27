#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=202
log "limit is ${CHANNEL_LIMIT}"

for item in standard blue latest staging; do
    log "checking ${item}"
done
