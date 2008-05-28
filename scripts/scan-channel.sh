#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=45
log "limit is ${CHANNEL_LIMIT}"

for item in local fallback; do
    log "checking ${item}"
done
