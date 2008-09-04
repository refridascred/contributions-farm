#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=477
log "limit is ${CHANNEL_LIMIT}"

for item in stable standard eu-west edge; do
    log "checking ${item}"
done
