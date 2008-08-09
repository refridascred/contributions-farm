#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback standard strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=425
log "limit is ${CHANNEL_LIMIT}"
