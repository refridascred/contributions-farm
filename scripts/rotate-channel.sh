#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=142
log "limit is ${CHANNEL_LIMIT}"

for item in local eu-west stable green; do
    log "checking ${item}"
done
