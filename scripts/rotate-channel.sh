#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=140
log "limit is ${CHANNEL_LIMIT}"

for item in latest open cached edge; do
    log "checking ${item}"
done
