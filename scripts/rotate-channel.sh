#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=357
log "limit is ${CHANNEL_LIMIT}"

for item in stable edge cached; do
    log "checking ${item}"
done
