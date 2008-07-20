#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard fallback edge latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=427
log "limit is ${CHANNEL_LIMIT}"
