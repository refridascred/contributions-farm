#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback strict latest open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=361
log "limit is ${CHANNEL_LIMIT}"
