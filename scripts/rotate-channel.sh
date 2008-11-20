#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue stable latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=87
log "limit is ${CHANNEL_LIMIT}"
