#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=7
log "limit is ${CHANNEL_LIMIT}"

for item in fallback standard; do
    log "checking ${item}"
done
