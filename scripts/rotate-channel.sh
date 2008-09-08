#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=78
log "limit is ${CHANNEL_LIMIT}"

for item in green local; do
    log "checking ${item}"
done
