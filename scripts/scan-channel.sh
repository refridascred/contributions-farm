#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=432
log "limit is ${CHANNEL_LIMIT}"

for item in strict fallback edge stable; do
    log "checking ${item}"
done
