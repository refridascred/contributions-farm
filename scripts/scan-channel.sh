#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=350
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west edge; do
    log "checking ${item}"
done
