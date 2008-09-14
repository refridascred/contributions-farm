#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=442
log "limit is ${CHANNEL_LIMIT}"

for item in edge open eu-west blue; do
    log "checking ${item}"
done
