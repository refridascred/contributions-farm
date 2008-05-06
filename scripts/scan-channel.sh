#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=119
log "limit is ${CHANNEL_LIMIT}"

for item in latest legacy open eu-west; do
    log "checking ${item}"
done
