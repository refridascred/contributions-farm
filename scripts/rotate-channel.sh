#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard fallback latest cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=373
log "limit is ${CHANNEL_LIMIT}"
