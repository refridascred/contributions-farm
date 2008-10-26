#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=62
log "limit is ${CHANNEL_LIMIT}"

for item in fallback legacy local stable; do
    log "checking ${item}"
done
