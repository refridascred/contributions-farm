#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=247
log "limit is ${CHANNEL_LIMIT}"

for item in stable strict local; do
    log "checking ${item}"
done
