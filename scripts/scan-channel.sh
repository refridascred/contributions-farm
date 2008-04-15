#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=331
log "limit is ${CHANNEL_LIMIT}"

for item in fallback cached stable blue; do
    log "checking ${item}"
done
