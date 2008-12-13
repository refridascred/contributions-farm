#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=431
log "limit is ${CHANNEL_LIMIT}"

for item in fallback blue legacy; do
    log "checking ${item}"
done
