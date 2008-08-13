#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=230
log "limit is ${CHANNEL_LIMIT}"

for item in fallback standard strict; do
    log "checking ${item}"
done
