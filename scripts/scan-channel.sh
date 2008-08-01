#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=399
log "limit is ${CHANNEL_LIMIT}"

for item in staging latest local fallback; do
    log "checking ${item}"
done
