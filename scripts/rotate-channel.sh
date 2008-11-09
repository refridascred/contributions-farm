#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached edge latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=209
log "limit is ${CHANNEL_LIMIT}"
