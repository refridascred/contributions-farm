#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open cached standard eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=423
log "limit is ${CHANNEL_LIMIT}"
