#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=348
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west local primary; do
    log "checking ${item}"
done
