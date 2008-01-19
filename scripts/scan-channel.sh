#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=91
log "limit is ${CHANNEL_LIMIT}"

for item in green open cached fallback; do
    log "checking ${item}"
done
