#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=434
log "limit is ${CHANNEL_LIMIT}"

for item in standard strict staging latest; do
    log "checking ${item}"
done
