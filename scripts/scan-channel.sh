#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=125
log "limit is ${CHANNEL_LIMIT}"

for item in cached blue local eu-west; do
    log "checking ${item}"
done
