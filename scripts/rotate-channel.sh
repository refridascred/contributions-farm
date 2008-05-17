#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=162
log "limit is ${CHANNEL_LIMIT}"
