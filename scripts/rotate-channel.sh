#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=275
log "limit is ${CHANNEL_LIMIT}"

for item in latest standard; do
    log "checking ${item}"
done
