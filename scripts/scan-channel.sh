#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=271
log "limit is ${CHANNEL_LIMIT}"
