#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=377
log "limit is ${CHANNEL_LIMIT}"

for item in blue cached local; do
    log "checking ${item}"
done
