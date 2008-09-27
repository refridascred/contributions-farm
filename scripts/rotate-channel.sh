#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=86
log "limit is ${CHANNEL_LIMIT}"

for item in blue primary strict; do
    log "checking ${item}"
done
