#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard fallback staging stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=412
log "limit is ${CHANNEL_LIMIT}"
