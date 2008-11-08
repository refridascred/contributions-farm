#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable local latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=474
log "limit is ${CHANNEL_LIMIT}"
