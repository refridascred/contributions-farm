#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge primary cached fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=139
log "limit is ${CHANNEL_LIMIT}"
