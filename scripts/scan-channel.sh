#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=151
log "limit is ${CHANNEL_LIMIT}"

for item in latest local fallback cached; do
    log "checking ${item}"
done
