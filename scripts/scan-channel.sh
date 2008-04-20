#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=307
log "limit is ${CHANNEL_LIMIT}"

for item in stable cached strict eu-west; do
    log "checking ${item}"
done
