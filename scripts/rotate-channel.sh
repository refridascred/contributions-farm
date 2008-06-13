#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=351
log "limit is ${CHANNEL_LIMIT}"
