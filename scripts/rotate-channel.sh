#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=279
log "limit is ${CHANNEL_LIMIT}"

for item in standard stable legacy; do
    log "checking ${item}"
done
