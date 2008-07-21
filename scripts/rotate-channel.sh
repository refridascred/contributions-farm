#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=210
log "limit is ${CHANNEL_LIMIT}"
