#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=200
log "limit is ${CHANNEL_LIMIT}"

for item in open standard eu-west; do
    log "checking ${item}"
done
