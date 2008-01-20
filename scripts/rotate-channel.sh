#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=331
log "limit is ${CHANNEL_LIMIT}"

for item in staging open; do
    log "checking ${item}"
done
