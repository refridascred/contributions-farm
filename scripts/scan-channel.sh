#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=68
log "limit is ${CHANNEL_LIMIT}"
