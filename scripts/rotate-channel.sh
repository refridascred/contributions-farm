#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable blue latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=373
log "limit is ${CHANNEL_LIMIT}"
