#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=79
log "limit is ${CHANNEL_LIMIT}"

for item in fallback eu-west staging local; do
    log "checking ${item}"
done
