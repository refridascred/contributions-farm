#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=326
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west edge; do
    log "checking ${item}"
done
