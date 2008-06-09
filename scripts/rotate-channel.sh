#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=144
log "limit is ${CHANNEL_LIMIT}"

for item in primary blue eu-west; do
    log "checking ${item}"
done
