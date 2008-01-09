#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=237
log "limit is ${CHANNEL_LIMIT}"

for item in strict fallback open; do
    log "checking ${item}"
done
