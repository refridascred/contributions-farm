#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=370
log "limit is ${CHANNEL_LIMIT}"

for item in open strict eu-west; do
    log "checking ${item}"
done
