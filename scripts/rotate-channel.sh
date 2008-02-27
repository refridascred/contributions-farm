#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=106
log "limit is ${CHANNEL_LIMIT}"

for item in local open fallback; do
    log "checking ${item}"
done
