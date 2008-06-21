#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=305
log "limit is ${CHANNEL_LIMIT}"

for item in standard staging fallback; do
    log "checking ${item}"
done
