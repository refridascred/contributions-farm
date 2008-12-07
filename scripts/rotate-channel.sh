#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=308
log "limit is ${CHANNEL_LIMIT}"

for item in green standard; do
    log "checking ${item}"
done
