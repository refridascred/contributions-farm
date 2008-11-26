#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=397
log "limit is ${CHANNEL_LIMIT}"

for item in local edge; do
    log "checking ${item}"
done
