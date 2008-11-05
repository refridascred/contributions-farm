#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=253
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west strict open edge; do
    log "checking ${item}"
done
