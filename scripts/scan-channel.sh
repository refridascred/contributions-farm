#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=95
log "limit is ${CHANNEL_LIMIT}"
