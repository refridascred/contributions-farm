#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=64
log "limit is ${CHANNEL_LIMIT}"

for item in stable legacy edge eu-west; do
    log "checking ${item}"
done
